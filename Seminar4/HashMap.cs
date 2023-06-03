// Сделано на семинаре
public class HashMap<K, V> {
    int size = 16;
  
    Node<K, V>[] nodes = new Node[size];

    public V put(K key, V value) {
        Node<K, V> newNode = new Node<>(key, value);
        int index = getIndex(key);
        Node<K, V> currentNode = nodes[index];
        while(currentNode != null) {
            if (currentNode.key == key) {
                V tmp = currentNode.value;
                currentNode.value = value;
                return tmp;
            }
            currentNode = currentNode.nextNode;
        }
        newNode.nextNode = nodes[index];
        nodes[index] = newNode;
        return null;
    }

    private int getIndex(K key) {
        return Math.abs(key.GetHashCode()) % size;
    }

    public V get(K key) {
      int index = getIndex(key);
      Node<K, V> node = nodes[index];
      while(node != null) {
        if (node.key.equals(key)) {
          return node.value;
        }
        node = node.nextNode;
      }
      return null;
    }

    public V remove(K key) {
      int index = getIndex(K key);
      Node<K, V> currentNode = nodes[index];
      Node<K, V> prev = null;
      while (currentNode != null) {
        if (currentNode.key.equals(key)) {
          V tmp = currentNode.value;
          if (prev == null) 
            nodes[index] = currentNode.nextNode;
          else if (currentNode.nextNode == null) 
              prev.nextNode = null;
                else prev.nextNode = currentNode.nextNode;
          return tmp;      
        }
        prev = currentNode;
        currentNode = currentNode.nextNode;
      }
      return null;
    }

//  Выполнено дома
    public V replays(K key, V value) {
      int index = getIndex(key);
      Node<K, V> currentNode = nodes[index];
      while (currentNode != null) {
        if (currentNode.key.equals(key)) {
          int tmp = currentNode.value;
          currentNode.value = value;
          return tmp;
        }
        currentNode = currentNode.nextNode;
      }
      return null;
    }

    public int size() {
      int count = 0;
      for (int i = 0; i < size; i++) {
        Node<K, V> node = nodes[i];
        while (node != null) {
          count++;
          node = node.nextNode;
        }
      }
      return count;
    }

    public boolean containsKey(K key) {
      for (int i = 0; i < size; i++) {
        Node<K, V> node = nodes[i];
        while (node != null) {
          if (node.key.equals(key)) {
            return true;
          }
          node = node.nextNode;
        }
      }
      return false;
    }

    public boolean containsValue(V value) {
      for (int i = 0; i < size; i++) {
        Node<K, V> node = nodes[i];
        while (node != null) {
          if (node.value == value) return true;
          node = node.nextNode;
        }
      }
      return false;
    }
}   
